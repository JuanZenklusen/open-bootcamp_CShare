/*Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18*/

int i = 20;
Console.WriteLine("Verificar si 'i' es mayor o igual a 18 " + (i>=18));

/*Un char es ‘a’*/

char b = 'a';
Console.WriteLine("¿El char b es igual 'a'? " + (b == 'a'));

/*
Se cumplen dos conciones a la vez (ambas verdaderas)*/

Console.WriteLine("Ambas son verdaderas? " + ((i >= 18) && (b == 'a')));

/*
Se cumple una de dos condiciones a la vez (una true y otra false)*/

Console.WriteLine("¿Una de las dos es verdadera y otra es falsa? " + ((i < 18) || (b == 'a')));

/*
Nota: puedes escribir estos datos por consola si prefieres verlos. 
La idea del ejercicio es almacenar los datos en los tipos más adecuados.*/
