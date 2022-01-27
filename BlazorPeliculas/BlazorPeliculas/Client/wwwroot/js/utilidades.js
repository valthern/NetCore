function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount").then(result => {
        console.log(`Conteo desde Javascript: ${result}`)
    })
}

function pruebaPuntoNetInstancia(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount")
}