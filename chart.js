const barCtx = document.getElementById("barChart").getContext("2d");

if (window.barChartInstance) {
    window.barChartInstance.destroy();
}

window.barChartInstance = new Chart(barCtx, {
    type: "bar",
    data: {
        labels: labels,
        datasets: [{
            label: "Emission (kg CO₂e)",
            data: values,
            backgroundColor: "#0d6efd"
        }]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        resizeDelay: 200,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});
