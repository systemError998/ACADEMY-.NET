let elenco = [
    {
        nome: "Giovanni",
        cogn: "Pace",
        matr: 1234
    },
    {
        nome: "Valeria",
        cogn: "Verdi",
        matr: 1235
    },
    {
        nome: "Mario",
        cogn: "Rossi",
        matr: 1236
    }
]

function aggiungiStudente(){
    let varNome = document.getElementById("input-nome").value;
    let varCogn = document.getElementById("input-cogn").value;
    let varMatr = document.getElementById("input-matr").value;

    let stud = {
        nome: varNome,
        cogn: varCogn,
        matr: varMatr
    }

    elenco.push(stud);
    stampaTabella();
}

function stampaTabella(){
    let contenitore = "";
    for(let [index,item] of elenco.entries()){
        contenitore += `
            <tr>
                <td>${index+1}</td>
                <td>${item.nome}</td>
                <td>${item.cogn}</td>
                <td>${item.matr}</td>
            </tr>
        `
    }
    document.querySelector("#corpo-tabella").innerHTML = contenitore;
}

stampaTabella();
