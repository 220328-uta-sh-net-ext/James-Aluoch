#! /bin/bash
# FizzBuzz program using for loop and conditional statements
   echo "Please enter number between 1 and 20 only:"
   read  number

for ((number = 0; number <= 20; number++))
do
   if (($number % 3 == 0))
   then
   echo "fizz"
   elif (($number % 5  == 0 ))
   then 
     echo "buzz"
   elif (($number % 3 == 0 &&  $number % 5 == 0 ))
   then 
      echo  "fizzbuzz"
   elif (($number % 3  != 0 &&  $number %  5  != 0 ))
   then
     echo "nothing"
   elif (($number  < 1= 0 &&  $number  > 20 ))
     then
      echo "Number enter is out of range or invalid value"
    else
     echo "$number"
   fi
done
