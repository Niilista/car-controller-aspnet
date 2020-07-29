
var regCarBTN = document.getElementById("regCarBTN");

regCarBTN.addEventListener('click', callCreatePerson);


function callCreatePerson() {
    var placaReg = document.getElementById("placa");
    var modeloReg = document.getElementById("modelo");
    var marcaReg = document.getElementById("marca");
    var cpfReg = document.getElementById("cpf");
    $.ajax({
        url: 'CadastrarCarro',
        data: {
            placa: placaReg.value,
            modelo: modeloReg.value,
            marca: marcaReg.value,
            cpf: cpfReg.value
        },
        method: 'POST',
        dataType: "json"
    }).then(function (data) {
        console.log(data);
    });
}