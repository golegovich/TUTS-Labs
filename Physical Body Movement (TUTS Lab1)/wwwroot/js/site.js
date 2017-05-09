function drawChart(type) {
	$("#error").addClass("hide");
	$.get("/Home/GetChartData",
		{
			tg: $("#Tg").val(),
			tu: $("#Tu").val(),
			t: $("#T").val(),
            thetaCoefficient: $("#thetaCoefficient").val(),
			n: $("#N").val(),
			type: type
		},
		function (data) {
			if (!data.isValid) {
				$("#error").toggle();
				$("#error")[0].textContent = "You entered wrong data. All values must be doubles";
				$("#error").removeClass("hide");
				return;
			}

			var xSeries = data.x.slice();
			xSeries.unshift("n");
			var ySeries = data.y.slice();
			ySeries.unshift("x");
			var thetaSeries = data.theta.slice();
			thetaSeries.unshift("θ");
			c3.generate({
				bindto: "#chart",
				data: {
					x: "n",
					columns: [
						xSeries,
						ySeries,
						thetaSeries
						//["x", 0.01, 0.05, 0.1, 0.5, 1, 2],
						//["dx/dt", 1, 2, 3, 4, 5, 6]
					]
				}
			});
		}
	);
}