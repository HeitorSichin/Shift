const urlBase = 'https://localhost:5001/v1';


$(document).ready(function () {
    OrdemServico.PageLoad();
});

OrdemServico = {
    PageLoad: () => {
        //OrdemServico.CarregarDDLPostoColeta();
    },

    GetDate: () => {
        var today = new Date();

        return today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
    },

    AbrirModalCadastro: () => {
        $("#dataCadastro").val(OrdemServico.GetDate());
        OrdemServico.CarregarDDLPostoColeta();
        OrdemServico.CarregarDDLPaciente();
        OrdemServico.CarregarDDLMedico();
        OrdemServico.CarregarDDLConvenio();

        $("#modalCadastroOrdemServico").modal({
            backdrop: false,
            show: true
        });

    },

    AbrirModalCadastroExame: () => {
        $("#modalCadastroExame").modal({
            backdrop: false,
            show: true
        });
    },

    CarregarDDLPostoColeta: () => {
        $.get(`${urlBase}/postocoletas`, function (data) {
            var opt = '<option value="-1">Selecione...</option>';
            for (var i = 0; i < data.length; i++) {
                opt += `<option value="${data[i].id}">${data[i].descricao}</option>`;
            }
            $("#postoColeta").append(opt);
        });
    },

    CarregarDDLPaciente: () => {
        $.get(`${urlBase}/pacientes`, function (data) {
            var opt = '<option value="-1">Selecione...</option>';
            for (var i = 0; i < data.length; i++) {
                opt += `<option value="${data[i].id}">${data[i].nome}</option>`;
            }
            $("#paciente").append(opt);
        });
    },

    CarregarDDLMedico: () => {
        $.get(`${urlBase}/medicos`, function (data) {
            var opt = '<option value="-1">Selecione...</option>';
            for (var i = 0; i < data.length; i++) {
                opt += `<option value="${data[i].id}">${data[i].nome}</option>`;
            }
            $("#medico").append(opt);
        });
    },

    CarregarDDLConvenio: () => {
        $.get(`${urlBase}/convenios`, function (data) {
            var opt = '<option value="-1">Selecione...</option>';
            for (var i = 0; i < data.length; i++) {
                opt += `<option value="${data[i].id}">${data[i].descricao}</option>`;
            }
            $("#convenio").append(opt);
        });
    },

    SalvarOrdemServico: () => {
        alert("implementando...");
    },

    SalvarExame: () => {

    }
}