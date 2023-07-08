document.addEventListener('DOMContentLoaded', function () {
    const emailField = document.getElementById('emailField');
    const passwordField = document.getElementById('passwordField');
    const proceedBtn = document.getElementById('proceedBtn');
    const signInBtn = document.getElementById('signInBtn');

    proceedBtn.addEventListener('click', function () {
        emailField.style.display = 'none';
        passwordField.style.display = 'block';
        proceedBtn.style.display = 'none';
        signInBtn.style.display = 'block';