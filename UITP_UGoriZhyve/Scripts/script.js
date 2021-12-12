//console.log(window.screen.availWidth);
//adaptivMenu
let mobileMenu = document.querySelector(".mobile__menu");
let mobileMenuBtn = document.querySelectorAll(".btnOnMenu");
let body = document.querySelector("body");



for (let i = 0; i < mobileMenuBtn.length; i++) {
    mobileMenuBtn[i].addEventListener("click", (e) => {
        mobileMenu.classList.toggle("active");
        setTimeout(() =>
            body.classList.toggle("hidden"), 2000
        );
    })
}
//form valid

document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('form__body');
    form.addEventListener('submit', formSend);

    function formSend(e) {
        e.preventDefault();
        let error = formValidate(form);

        if (error === 0) {

        }
        else {
            alert("зоповність обов'язкові поля");
        }
    }




    function formValidate(form) {
        let error = 0;
        let formReq = document.querySelectorAll('._req')

        for (let index = 0; index < formReq.length; index++) {
            const input = formReq[index];
            formRemoveError(input);

            if (input.classList.contains('enterEmail')) {
                if (emailTest(input)) {
                    formAddError(input);
                    error++
                }
            }
            else {
                if (input.value === '') {
                    formAddError(input);
                    error++;
                }
            }


        }
    }
    function formAddError(input) {
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

document.addEventListener('DOMContentLoaded', function () {
    const formR = document.querySelector('.form__bodyR');
    addEventListener("input", () => {
        const listSkis = formR.listSkis.value;
        let range = document.querySelector(".range"),
            cost = document.querySelector(".cost");

        console.log(listSkis);
        if (listSkis === "Ski-LightF(Child, female)") {
            cost.innerHTML = 120 * range.value + "₴";
        }
        else if (listSkis === "Ski-LightM(Child, male)") {
            cost.innerHTML = 120 * range.value + "₴";
        }
        else if (listSkis === "Ski-MediumF(Adult, female)") {
            cost.innerHTML = 240 * range.value + "₴";
        }
        else if (listSkis === "Ski-MediumM(Adult, male)") {
            cost.innerHTML = 240 * range.value + "₴";
        }
        else {

        }
    })
    //formR.addEventListener('submit' , formSend);



})