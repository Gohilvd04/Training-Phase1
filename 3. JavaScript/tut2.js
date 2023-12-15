const fs = require("fs");
const text1 = fs.readFileSync("XHR.html","utf-8");
console.log(text1);

let text = "Vishal created this file using node js";
fs.writeFileSync("vishal.txt",text);