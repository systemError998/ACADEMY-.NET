// ------------------- TYPE -------------------
//Un tipo è simile ad una classe ma ha solamente ATTRIBUTI
// type Persona = {
//     nominativo : string,
//     eta : number
// }

// let gio : Persona = {
//     nominativo: "Giovanni",
//     eta: 37
// }

// //Tipizzazione di una funzione. :Persona indica che il valore restituito sarà di tipo persona
// function getpersona() : Persona {
//     return {
//         nominativo: "Giovanni",
//         eta: 37
//     }
// }


// ------------------- INTERFACE -------------------
// al contrrio di c sharp qui l'interfaccia ha solo attributi
interface Animale{
    nome: string,
    specie: string
}

function getAnimale() : Animale{
    return {
        nome: "baby",
        specie: "testa di gatto"
    }
}