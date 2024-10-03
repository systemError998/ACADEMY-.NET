

let btn = document.querySelector("#btn-invia");
// console.log(btn);

function inviaTemp() {
    let inputTemp = document.querySelector("#inputTemp").value
    console.log(inputTemp)
    if(inputTemp>37.5 || inputTemp<33){
        //console.log("non puoi entrare");
        let esito = document.querySelector(".esito")
        esito.innerText = "non puoi entrare"
    }
    return inputTemp;
}

