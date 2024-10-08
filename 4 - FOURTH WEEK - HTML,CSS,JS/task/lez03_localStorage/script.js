localStorage.setItem("Nominativo", "Giovanni Paci");
localStorage.getItem("Nominativo");
localStorage.removeItem("Nominativo");

localStorage.setItem("Matricola", "AB1234");
localStorage.getItem("Matricola");

let persona = {
    nome: "Giovanni",
    cogn: "Pace",
    matr: "AB1234"
}
localStorage.setItem("oggetto", JSON.stringify(persona)) // outpu: [ object Object ]
console.log(JSON.parse(localStorage.getItem("oggetto")));
 