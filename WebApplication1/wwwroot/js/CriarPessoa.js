var CadPessoaBTN = document.getElementById("CadPessoaBTN");
var cpfInput = document.getElementById("cpf");
var nomeInput = document.getElementById("nome");

CadPessoaBTN.addEventListener('click', callCreatePerson)




function callCreatePerson() {
    $.ajax({
        url: 'CadastrarPessoa',
        data: {
            cpf: cpfInput.value,
            nome: nomeInput.value
            },
        method: 'POST',
        dataType: "json"
    }).then(function (data) {
        console.log(data);
    });
}