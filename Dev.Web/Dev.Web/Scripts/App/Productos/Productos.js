class Productos {
    constructor() {
        this.ObtenerProductos();
    }

    ObtenerProductos() {
        console.log('ObtenerProductos by contructor');
        $.get('https://localhost:44352/api/WeatherForecast/Get').done(function (r) {
            console.log(r);
        }).fail(function (err) {
            console.log(err);
        });
    }
}

new Productos();