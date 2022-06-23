#Irreducible Sum of Rationals
######C#
___
###Enunciado
You will have a list of rationals in the form

`lst = [ [numer_1, denom_1] , ... , [numer_n, denom_n] ]`<br/><br/>
or <br/><br/>
`lst = [ (numer_1, denom_1) , ... , (numer_n, denom_n) ]`

where all numbers are positive integers. You have to produce their sum N / D in an irreducible form: this means that N and D have only 1 as a common divisor.

Return the result in the form:

`[N, D]`

If the result is an integer (D evenly divides N) return:

`"n"`

If the input list is empty, return

`nil/None/null/Nothing`<br/><br/>

###Exemplo
`[ [1, 2], [1, 3], [1, 4] ]  -->  [13, 12]`<br>
`1/2  +  1/3  +  1/4     =      13/12`
___
_Link para o exercício no Codewars: (https://www.codewars.com/kata/5517fcb0236c8826940003c9)_