// usar a funcao "substituir" para percorrer a palavra e limpa-la
const substituir = require("./substituir");;

function limpar (texto) {

    // validação
    if (typeof texto !== "string") {
        return undefined;
    }

    // variavel para guardar os caracteres especiais
    var especiais = "!@#$%^&*()";
    
    // variavel para receber o texto inicial e posteriormente editar
    var resultado = texto;

    // vamos percorrer os especiais e adcionar um caso para o "@"
    for (var i=0; i<especiais.length; i++) {

    // verificar se o texto tiver "@"
        if (especiais[i] === "@") {
            resultado = substituir(resultado, especiais[i], " ");
        }
    // elimina os outros caracteres especiais
        else {
            resultado = substituir(resultado, especiais[i], "")
        }
    }

    return resultado;

}

module.exports = limpar;