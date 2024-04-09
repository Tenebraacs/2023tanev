//KARAKTERLÁNC TÍPUSOK

var s1 = "Almáspite";
document.write(s2, '<br>');

var s2 = new String("Almáspite");
document.write(s2, '<br>');

var s3 = new String(""); //üres string
document.write(s3, '<br>');

var s4 = new String;
document.write(s4, '<br>');

document.write("Szöveg hossza: ", s1.length, "<br>");
document.write("Szöveg első karaktere: ", s1.charAt(0), "<br>");
document.write("Szöveg utolsó karaktere: ", s1.charAt(s1.length - 1), "<br>");

