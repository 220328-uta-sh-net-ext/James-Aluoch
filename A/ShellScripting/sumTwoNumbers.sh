#!/bin/bash

read  -p "Please enter  first numbers: " x ;
read  -p "Please enter  second numbers: "  y;

intNum=-100

while [[ $intNum -le  100 ]] 
do
  echo "Display number from the loop === $intNum"
  #intNum=$(( $intNum + 1))
  if [[ $intNum -eq  0 ]]; then
    echo "Break the loop"
     break
   fi
      if [ $y -ne 0 ]
      then

       echo $((x+y));
       echo $((x-y));
       echo $((x*y));
       echo $((x%y));
      fi
   
 intNum=$(($intNum + 1))

done
exit 0;
