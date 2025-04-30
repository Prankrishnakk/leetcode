/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(num, target) {
    const array =[]
    for(let i =0; i<num.length-1;i++) {
        for(let j= i+1; j<num.length;j++){
            if( num[i]+num[j]==target)
            array.push(i,j);
            
        }
    } return array

    
}