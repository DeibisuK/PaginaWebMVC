const container = document.getElementById('container');
const registerBtn = document.getElementById('register');
const loginBtn = document.getElementById('login');
const alert = document.getElementById('alert-danger');
const mostrarRegistro = container.getAttribute("data-mostrar-registro");

// Manejar el clic en "Sign Up"
registerBtn.addEventListener('click', () => {
    container.classList.add("active");
});

// Manejar el clic en "Sign In"
loginBtn.addEventListener('click', () => {
    container.classList.remove("active");
});

// Cambiar bordes dinámicamente al terminar la transición
container.addEventListener('transitionend', (event) => {
    if (event.propertyName === 'transform') { // Detectar el final de la transición
        if (container.classList.contains('active')) {
            // Cambiar bordes al lado derecho
            container.style.borderRadius = '80px 0 0 80px';
        } else {
            // Cambiar bordes al lado izquierdo
            container.style.borderRadius = '0 80px 80px 0';
        }
    }
});