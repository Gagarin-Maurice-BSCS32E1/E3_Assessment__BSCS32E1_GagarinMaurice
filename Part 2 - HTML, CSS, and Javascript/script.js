function checkEvenOrOdd(number) {
    if (number % 2 === 0) {
      return "even";
    } else {
      return "odd";
    }
  }
  
  function displayResult() {
    var inputNumber = parseInt(prompt("Enter a number:"));
    var result = checkEvenOrOdd(inputNumber);
    var resultElement = document.getElementById("result");
    resultElement.textContent = "The number is " + result + ".";
  }
  
  document.getElementById("checkButton").addEventListener("click", displayResult);
  