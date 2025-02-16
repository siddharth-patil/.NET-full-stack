var input  = document.querySelector('input');

var data = [
    {name:"Siddharth", src:"https://media.istockphoto.com/id/686500880/photo/farmer-portrait-in-the-field-of-mustard-crop.webp?a=1&b=1&s=612x612&w=0&k=20&c=ZuTMSWu2-h8K4FqXWSk78QkfI0OhJWI55KRkUNiQBBA="},
    {name:"Vipul", src:"https://media.istockphoto.com/id/2148752264/photo/modern-indian-farmer-using-mobile-phone-technology-for-growth-and-development.webp?a=1&b=1&s=612x612&w=0&k=20&c=OdkY41zWmuuOBX_Aw5-Y4DK9fyMj6Nb3hvWw5L2nLyU="},
    {name:"Vishakha", src:"https://media.istockphoto.com/id/2148752264/photo/modern-indian-farmer-using-mobile-phone-technology-for-growth-and-development.webp?a=1&b=1&s=612x612&w=0&k=20&c=OdkY41zWmuuOBX_Aw5-Y4DK9fyMj6Nb3hvWw5L2nLyU="},
    {name:"Ram", src:"https://media.istockphoto.com/id/1424218363/photo/young-indian-farmer-at-cotton-agriculture-field.jpg?s=612x612&w=0&k=20&c=RPsFb4_Wu6mhlWKt3CwVsLNBYMp2SHwr5FgDeWha-7g="},
    {name:"Rama", src:"https://media.istockphoto.com/id/1424218363/photo/young-indian-farmer-at-cotton-agriculture-field.jpg?s=612x612&w=0&k=20&c=RPsFb4_Wu6mhlWKt3CwVsLNBYMp2SHwr5FgDeWha-7g="},
    {name:"Shiva", src:"https://media.istockphoto.com/id/577310258/photo/portrait-of-handsome-indian-male-chef-with-watermelon-and-knife.jpg?s=612x612&w=0&k=20&c=F9xJuX2YRZ7asPXACZUFLAeJB10oTbg6qH6FX43j-a4="}
];

var prsn = "";

data.forEach(function(elem){
    prsn += `<div class="person">
                    <div class="img">
                        <img
                            src="${elem.src}">
                    </div>
                    <h4>${elem.name}</h4>
                </div>`;
})

document.querySelector('.people').innerHTML = prsn;


input.addEventListener("input", function(){
    var matching = data.filter(function(obj){
        return obj.name.startsWith(input.value);
    })

    var newUsers = "";
    matching.forEach(function(elem){
        newUsers += `<div class="person">
                        <div class="img">
                            <img
                                src="${elem.src}">
                        </div>
                        <h4>${elem.name}</h4>
                    </div>`;
    })

    document.querySelector('.people').innerHTML = newUsers;
})
