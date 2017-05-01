function drawChart(parameters) {
    var chart = c3.generate({
        bindto: "#chart",
        data: {
            columns: [
                ["data1", 1, 2, 3, 4, 5, 6],
                //['data2', 50, 20, 10, 40, 15, 25]
            ]
        }
    });

    //require.config({
    //    baseUrl: "/js",
    //    paths: {
    //        d3: "http://d3js.org/d3.v3.min"
    //    }
    //});

    //require(["d3", "c3"], function (d3, c3) {
    //    var chart = c3.generate({
    //        bindto: "#chart",
    //        data: {
    //            columns: [
    //                ["data1", 1, 2, 3, 4, 5, 6],
    //                //['data2', 50, 20, 10, 40, 15, 25]
    //            ]
    //        }
    //    });
    //});

    //require(['Chart.min.js'], function (Chart) {
    //    var scatterChart = new Chart("pes", {
    //        type: "line",
    //        data: {
    //            datasets: [{
    //                label: "Scatter Dataset",
    //                data: [{
    //                    x: -10,
    //                    y: 0
    //                }, {
    //                    x: 0,
    //                    y: 10
    //                }, {
    //                    x: 10,
    //                    y: 5
    //                }]
    //            }]
    //        },
    //        options: {
    //            scales: {
    //                xAxes: [{
    //                    type: "linear",
    //                    position: "bottom"
    //                }]
    //            }
    //        }
    //    });
    //});   
}