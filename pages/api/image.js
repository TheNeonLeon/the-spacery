export default function GetImage(){
 return   fetch('https://api.nasa.gov/planetary/apod?api_key=5tQtFTZISzxLBAC055jvqGETs0xHfsSz0m5v6HcX')
    .then(response => response.json())
    .then((data) => console.log(data))
    
}