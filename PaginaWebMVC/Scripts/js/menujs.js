let listElements = document.querySelectorAll('.list__buttom--click');
const barra = document.querySelector('.fa-solid');
const nav = document.querySelector('.nav');




listElements.forEach(listElement => {
    listElement.addEventListener('click', () => {
        listElement.classList.toggle('arrow')

        let height = 0;
        let menu = listElement.nextElementSibling;

        if (menu.clientHeight == 0) {
            height = menu.scrollHeight;
        }
        menu.style.height = height + 'px';

        if (nav) {
            const estilo = getComputedStyle(nav);

            if (estilo.width === '49px') {
                nav.style.width = '250px';
            }
        }
    })

});

barra.addEventListener('click', () => {
    if (nav) {
        // Obtiene el estilo computado del elemento
        const estilo = getComputedStyle(nav);

        // Verifica si el ancho es exactamente "49px"
        if (estilo.width === '250px') {
            nav.style.width = '49px';
            listElements.forEach(listElement => {
                listElement.classList.toggle('arrow')

                let menu = listElement.nextElementSibling;

                
                menu.style.height = '0px';
            });
        } else {
            nav.style.width = '250px';
        }
    }
})