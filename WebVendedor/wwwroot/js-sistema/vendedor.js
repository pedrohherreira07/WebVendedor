async function salvar() {
    if (validarCampos("divPai")) {
        try {
            const dados = {
                Nome: getValue("nome"),

                Telefone: getValue("telefone"),

                Email: getValue("email"),

                Endereco: getValue("endereco")
            }

            const dadosJson = JSON.stringify(dados)

            const response = await fetch("/Vendedor/GravarMeusDados", {
                method: "put",

                headers: {
                    "Content-type": "application/json"
                },

                body: dadosJson
            })

            const responseDTO = await response.json()

            if (!response.ok) {
                exibirMsg(COD_ERRO, MSG_ERRO);
                return;
            }
        }
        catch {
            exibirMsg(COD_ERRO, MSG_ERRO);
        }
    }
}