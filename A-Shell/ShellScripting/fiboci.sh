#!/bin/bash

echo "How many number of terms to be generated ?"
  read number
function fib
{
  sampleInput=0
  secondInput=1
  result=0
  i=0
  #echo "Fibonacci Series up to $number terms :"
  echo "$sampleInput"
  echo "$secondInput"
  
  #while [[ $i -ge 40 ]]
  for ((i=0;i<=40;i++))
  do
   #if [ $number>0 && $number<=40 ]
   #then 
     # i=`expr $i + 1 `
      result=`expr $sampleInput + $secondInput`
      sampleInput=$secondInput
      secondInput=$result
      echo "$result"
   #fi
   #i=$(($i+1))
  # echo "result ofF ibonacci is: $result"
  done
}
result=`fib $number`
echo "$result"


