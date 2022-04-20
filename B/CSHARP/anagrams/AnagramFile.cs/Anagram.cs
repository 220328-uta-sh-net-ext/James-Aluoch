public static  bool  Anagram(string s1,string s2)
{
    const anagrams = (str1, str2) => {
    const newStr1 = str1.replace(/[^\w]/g, '').toLowerCase()
    const newStr2= str2.replace(/[^\w]/g, '').toLowerCase()if (newStr1.length !== newStr2.length) { return false }//create a hash map for both new words
    const obj1 = {},
             obj2= {}newStr1.split('')
     .forEach( char => {
    if(!obj1[char]){
      obj1[char] = 1
    } else {
      obj1[char] += 1
    }
  })newStr2.split('')
  .forEach( char => {
    if(!obj2[char]){
      obj2[char] = 1
    } else {
      obj2[char] += 1
    }
  })let result;//compare both maps and see if keys values are equal
  for (let char1 in obj1){
    if(Object.keys(obj2).includes(char1)){
      obj1[char1] === obj2[charA] ? result = true : result = false
    } else {
      result = false
    }
  }return result
}
