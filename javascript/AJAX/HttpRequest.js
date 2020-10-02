const { Console } = require("console");

var XMLHttpRequest = require("xmlhttprequest").XMLHttpRequest;

function reqListener()
{
  console.log(this.responseText);
}

//First create an XMLHttpRequest object 
var oReq = new XMLHttpRequest();
oReq.addEventListener('load',reqListener);
oReq.addEventListener('progress',updateProgress)
oReq.open('GET',"http://www.example.org/example.txt");
oReq.send();

//First create an XMLHttpRequest object 


function updateProgress(oEvent){}
function transferFailed(){}
function transferCanceled(){}
function transferComplete(){}

function loadPokemon()
{
  let xhttp = new XMLHttpRequest();
  // xhttp.addEventListener('load',reqListener)
  xhttp.open('GET','https://pokeapi.co/api/v2/pokemon/butterfree/',true);
  if(this.readyState == 4 && this.status == 200)
  {
    console.log(this.responseJSON)
  }
  xhttp.send();
};

loadPokemon();