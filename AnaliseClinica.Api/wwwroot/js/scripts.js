const urlBase = 'https://localhost:5001/v1';


$(document).ready(function () {
    OrdemServico.PageLoad();
});

OrdemServico = {
    PageLoad: () => {
        //OrdemServico.CarregarDDLPostoColeta();
        OrdemServico.FecharModalCadastro();
        OrdemServico.FecharModalCadastroExame();
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
        OrdemServico.CarregarDDLExame();

        $("#modalCadastroOrdemServico").modal({
            backdrop: false,
            show: true
        });

    },

    FecharModalCadastro: () => {
        $("#modalCadastroOrdemServico").on('hidden.bs.modal', function () {
            OrdemServico.LimparCadastroOrdemServico();
        });
    },

    AbrirModalCadastroExame: () => {
        $("#modalCadastroExame").modal({
            backdrop: false,
            show: true
        });
    },

    FecharModalCadastroExame: () => {
        $("#modalCadastroExame").on('hidden.bs.modal', function () {
            OrdemServico.LimparCadastroExame();
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

    CarregarDDLExame: () => {
        $.get(`${urlBase}/exames`, function (data) {
            var opt = '<option value="-1">Selecione...</option>';
            for (var i = 0; i < data.length; i++) {
                opt += `<option value="${data[i].id}">${data[i].descricao}</option>`;
            }
            $("#exame").append(opt);
        });
    },

    LimparCadastroOrdemServico: () => {
        $("#dataCadastro").val('');
        $("#postoColeta").val(-1);
        $("#paciente").val(-1);
        $("#medico").val(-1);
        $("#convenio").val(-1);
    },

    LimparCadastroExame: () => {
        $("#exame").val(-1);
        $("#entregaResultado").val('');
        $("#precoExame").val(0);
    },

    SalvarOrdemServico: () => {
        var data = $("#dataCadastro").val();
        var pacienteId = $("#paciente").val();
        var convenioId = $("#convenio").val();
        var postoColetaId = $("#postoColeta").val();
        var medicoId = $("#medico").val();

        var model = {
            data: data,
            pacienteId: pacienteId,
            convenioId: convenioId,
            postoColetaId: postoColetaId,
            medicoId: medicoId,
            exames: [
                {
                    "entregaResultado": "2019-06-26",
                    "preco": 123,
                    "exameId": 1
                },
                {
                    "entregaResultado": "2019-06-26",
                    "preco": 45,
                    "exameId": 2
                }
            ]
        };

        $.ajax({
            cache: false,
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(model),
            url: `${urlBase}/ordemservicos`,
            success: function (data) {
                console.log(data);

                var validacao = data.data.message.join('<br>');
                alert(data.message + '<br>' + validacao);
            },
            error: function (jqXHR) {
                alert('Ocorreu um erro interno.');
                console.log(jqXHR);
            }
        });
    },

    SalvarExame: () => {
        var tabela = $("#tabelaExames");
        var rows = '';
        var exameID = $("#exame").val();
        var exameDescricao = $("#exame option:selected").text();
        var entrega = $("#entregaResultado").val();
        var preco = $("#precoExame").val();
        var ordemServico = $("#OrdemServicoID").val();
        //var exameOrdemServico = $("#ExameOrdemServicoID").val();

        rows += '<tr>';
        rows += '<td><button class="btn btn-danger btn-sm btn-block"><i class="fa fa-trash-alt"></i></button></td>';
        rows += `<td>${exameID}</td>`;
        rows += `<td>${exameDescricao}</td>`;
        rows += `<td>${entrega}</td>`;
        rows += `<td>${preco}</td>`;
        rows += '</tr>';

        tabela.find('tbody').append(rows);
        OrdemServico.LimparCadastroExame();

    }
}