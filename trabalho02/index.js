const substituir = require("./substituir");
const limpar = require("./limpar");

const res = substituir("hello world", "o", "a");
console.log(res); // "hella warld"
console.log(substituir("JavaScript", "a", "o")); // "JovoScript"
console.log(substituir("123abc!@#", "a", "x")); // "123xbc!@#"
console.log(substituir("JavaScript", "a", "")); // "JvScript"
// casos especiais
console.log(substituir("", "a", "b")); // ""
console.log(substituir()); // undefined
console.log(substituir("hello world")); // undefined
console.log(substituir(12345, "2", "9")); // undefined


const res2 = limpar("hello@world!");
console.log(res); // "hello world"
console.log(limpar("Java#Script$ is %awesome^")); // "JavaScript is awesome"
console.log(limpar("123abc!@#")); // "123abc"
// casos especiais
console.log(limpar("")); // ""
console.log(limpar("!@#$%^&*()")); // ""
console.log(limpar()); // undefined
console.log(limpar(12345)); // undefined