//Функция вычисления n-ное число Фибоначчи
let rec Fib n = if n < 2 then 1 else Fib (n - 1) + Fib (n - 2)

//Дискриминант
let Discriminant a b c = b * b - 4.0 * a * c

//Функция нахождения корней квадратного уравнения
let QuadraticEquation a b c = 
    let d = Discriminant a b c
    let calc result = (result (-b) (sqrt d)) / (2.0 * a)
    (calc (+), calc(-))


printfn $"{Fib 10}"
printfn $"{QuadraticEquation 1 4 -5}"