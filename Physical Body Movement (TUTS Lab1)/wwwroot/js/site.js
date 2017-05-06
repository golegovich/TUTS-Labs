﻿function drawChart() {
    $("#error").addClass("hide");
    $.get("/Home/GetChartData",
        {
            a1: $("#a1").val(),
            a2: $("#a2").val(),
            distance: $("#distance").val(),
            time: $("#time").val()
        },
        function (data) {
            if (!data.isValid) {
	            $("#error").toggle();
                //var divForError = $("#error")[0];
                $("#error")[0].textContent = "You entered wrong data. All values must be doubles";
	            $("#error").removeClass("hide");
                return;
            }

            var xAxis = data.x.slice();
            xAxis.unshift("x");
            var yAxis = data.y.slice();
            yAxis.unshift("dx/");
            c3.generate({
                bindto: "#chart",
                data: {
                    x: "x",
                    columns: [
                        xAxis,
                        yAxis
                        //["x", 0.01, 0.05, 0.1, 0.5, 1, 2],
                        //["dx/dt", 1, 2, 3, 4, 5, 6]
                    ]
                }
            });
        }
    );
}