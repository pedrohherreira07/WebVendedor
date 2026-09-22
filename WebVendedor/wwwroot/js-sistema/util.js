cod = 1 //Certo
cod = -1 //Erro
cod = 0 //Aviso
cod = 2 //Info

function exibirMsg(cod, msg) {
    const divMsg = getElemento("msg_topo")

    switch (cod) {
        case COD_ERRO:
            divMsg.innerHTML = `<div class="alert alert-danger">${msg}</div>`
            break;

        case COD_SUCESSO:
            divMsg.innerHTML = `<div class="alert alert-success">${msg}</div>`
            break;

        case COD_WARNING:
            divMsg.innerHTML = `<div class="alert alert-warning">${msg}</div>`
            break;

        case COD_INFO:
            divMsg.innerHTML = `<div class="alert alert-info">${msg}</div>`
            break;
    }

    setTimeout(() => {
        divMsg.innerHTML = ""
    },3000)
}

function getValue(id) {

    const campo = document.getElementById(id).value

        if(!campo){
            console.warn(`o ${id} não existe`)
            return null
        }

        return campo.value.trim()
}

function getElemento(id) {

    const item = document.getElementById(id)

    if (!item) {
        console.warn(`o ${id} não existe`)
        return null
    }

    return item
}

function validarCampos(idPai) {
    const container = getElemento(idPai)

    if (!container) {
        console.warn(`o ${id} não existe`)
        return null
    }

    let flag = true

    const elementos = container.querySelectorAll("[obg]")

    elementos.forEach(campo => {
        if (campo.value.trim() == "") {
            campo.classList.add("campo-erro")
            flag = false;
        } else {
            campo.classList.remove("campo-erro")
        }
    })

    if (!flag) {
        exibirMsg(COD_WARNING, MSG_OBG)
    }

    return flag
}
