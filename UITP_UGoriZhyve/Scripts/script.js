//console.log(window.screen.availWidth);
//adaptivMenu
let mobileMenu = document.querySelector(".mobile__menu");
let mobileMenuBtn = document.querySelectorAll(".btnOnMenu");
let body = document.querySelector("body");



for (let i = 0 ; i < mobileMenuBtn.length; i++){
     mobileMenuBtn[i].addEventListener("click" , (e) =>{
         mobileMenu.classList.toggle("active");
         setTimeout(() =>  
            body.classList.toggle("hidden") ,2000
        );
     })
}
//form valid

document.addEventListener('DOMContentLoaded', function(){
    const form = document.getElementById('form__body');
    form.addEventListener('submit' , formSend);

    function formSend(e){
        e.preventDefault();
        let error = formValidate(form);

        if(error === 0){

        }
        else{
            alert("зоповність обов'язкові поля");
        }
    }




    function formValidate(form) {
        let error = 0;
        let formReq = document.querySelectorAll('._req')
        
        for (let index = 0; index < formReq.length; index++) {
            const input = formReq[index];
            formRemoveError(input);

            if (input.classList.contains('enterEmail')){
                if (emailTest(input)){
                    formAddError(input);
                    error++
                }
            }
                else{
                    if(input.value === ''){
                        formAddError(input);
                        error++;
                    }
                }
           
            
        }
    }
    function formAddError(input){
        input.parentElement.classList.add('_error');
        input.classList.add('_error');
    }
    function formRemoveError(input) {
        input.parentElement.classList.remove('_error');
        input.classList.remove('_error');
    }
    function emailTest(input) {
        return !/^\w+([\.-]?\w+)+@\w+([\.-]?\w+)*(\.\w{2,8})+$/.test(input.value);
    }
})
//calc

document.addEventListener('DOMContentLoaded', function(){
    const formR = document.querySelector('.form__bodyR');
    addEventListener("input" , () => {
        const listSkis = formR.listSkis.value;
        let range = document.querySelector(".range"),
            cost = document.querySelector(".cost");

        console.log(listSkis);
        if(listSkis == "Ski-LightF(Child, female)"){
            cost.innerHTML = 120 * range.value+ "₴";            
        }
        else if(listSkis === "premiumSkis"){
            if(range.value == 1){
                cost.innerHTML = 250 + "₴";
            }
            else if(range.value == 2){
                cost.innerHTML = 500 + "₴";
            }
            else if(range.value == 3){
                cost.innerHTML = 750+ "₴";
            }
            else if(range.value == 4){
                cost.innerHTML = 1000+ "₴";
            }
            else if(range.value == 5){
                cost.innerHTML = 1250+ "₴";
            }
            else if(range.value == 6){
                cost.innerHTML = 1500+ "₴";
            }
            else if(range.value == 7){
                cost.innerHTML = 1750+ "₴";
            }
        }
        else if(listSkis === "topSkis"){
            if(range.value == 1){
                cost.innerHTML = 320+ "₴";
            }
            else if(range.value == 2){
                cost.innerHTML = 640+ "₴";
            }
            else if(range.value == 3){
                cost.innerHTML = 960+ "₴";
            }
            else if(range.value == 4){
                cost.innerHTML = 1280+ "₴";
            }
            else if(range.value == 5){
                cost.innerHTML = 1600+ "₴";
            }
            else if(range.value == 6){
                cost.innerHTML = 1920+ "₴";
            }
            else if(range.value == 7){
                cost.innerHTML = 2290+ "₴";
            }
        }
        else if(listSkis === "standartKidsSkis"){
            if(range.value == 1){
                cost.innerHTML = 120+ "₴";
            }
            else if(range.value == 2){
                cost.innerHTML = 240+ "₴";
            }
            else if(range.value == 3){
                cost.innerHTML = 360+ "₴";
            }
            else if(range.value == 4){
                cost.innerHTML = 580+ "₴";
            }
            else if(range.value == 5){
                cost.innerHTML = 700+ "₴";
            }
            else if(range.value == 6){
                cost.innerHTML = 820+ "₴";
            }
            else if(range.value == 7){
                cost.innerHTML = 940+ "₴";
            }
        }
        else if(listSkis === "premiumKidsSkis"){
            if(range.value == 1){
                cost.innerHTML = 180+ "₴";
            }
            else if(range.value == 2){
                cost.innerHTML = 360+ "₴";
            }
            else if(range.value == 3){
                cost.innerHTML = 520+ "₴";
            }
            else if(range.value == 4){
                cost.innerHTML = 670+ "₴";
            }
            else if(range.value == 5){
                cost.innerHTML = 810+ "₴";
            }
            else if(range.value == 6){
                cost.innerHTML = 950+ "₴";
            }
            else if(range.value == 7){
                cost.innerHTML = 1070+ "₴";
            }
        }
        else{

        }
    })
    //formR.addEventListener('submit' , formSend);



})
