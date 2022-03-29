var lista = [12, 15.6, 17, 'Fabio'];


var objetos = [
    {
        nome: 'Fabio',
        idade: 32,
        altura: 168,
        especialidades: ['Programação', 'Ingles', 'Banco de Dados']
    },
    {
        nome: 'Luiz',
        idade: 25,
        altura: 135,
        especialidades: ['Vijia', 'Perto', 'Preguiçoso']
    }
]

function alterarParagrafo(cor, tamanho, texto, id) {
    var paragrafo = document.getElementById(id)

    paragrafo.style.color = cor;
    paragrafo.style.fontSize = tamanho;
    paragrafo.innerHTML = texto;
}