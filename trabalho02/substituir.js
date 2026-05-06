function substituir (texto, alvo, novo) {

    // validação dos parâmetros
    if (typeof texto !== "string" || typeof alvo !== "string" || typeof novo !== "string") {
        return undefined;
    }

    // se o alvo ter mais de um digito, sera invalidado
    if (alvo.length !== 1) {
        return undefined;
    }

    // variavel para receber a nova string
    var resultado = ""

    // percorrendo o texto para encontrar uma nova resposta
    for (var i=0; i< texto.length; i++) {

        // se o alvo foi encontrado, o substitua
        if (texto[i] === alvo) {
            resultado = resultado + novo;
        }
        // quando nao encontra, guarda o valor real
        else {
            resultado = resultado + texto[i]
        }
    }
    return resultado;
}

module.exports = substituir;