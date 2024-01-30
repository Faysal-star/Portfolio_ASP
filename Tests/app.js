let title = document.querySelector(".title");
let img = document.getElementById("proP");

title.addEventListener('mouseenter' , () => {
    img.classList.add('glowing');
})

title.addEventListener('mouseleave' , () => {
    img.classList.remove('glowing');
})