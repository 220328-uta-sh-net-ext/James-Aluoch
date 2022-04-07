#!/bin/bash

echo "How many number of terms to be generated ?"
  read number
function fib
{
  sampleInput=0
  ysecondInput=1
  i=0
  echo "Fibonacci Series up to $number terms :"
  echo "$sampleInput"
  echo "$secondInput"
  
  while [[ $i -ge $number ]]
  do
   if [ $number>0 && $number<=40 ]
   then 
      i=`expr $i + 1 `
      temp =`expr $sampleInput + $secondInput`
      echo "$temp"
      sampleInput=$secondInput
      secondInput=$temp
   fi
   i= $(($i+1))
  done
}
result =`fib $number`
echo "$result"




