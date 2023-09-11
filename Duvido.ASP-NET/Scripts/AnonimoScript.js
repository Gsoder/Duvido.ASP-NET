window.onload = function(){

   
        // Quando um avatar é clicado
        $('.avatar-image').click(function () {
            var avatarNome = $(this).data('avatar'); // Obtenha o nome do avatar clicado
            var avatarUrl = '../Imagens/UsuarioAnonimo/Avatares/' + avatarNome;
            $('#avatar').css('background-image', 'url(' + avatarUrl + ')'); // Defina o avatar como background do elemento #avatar
    });


}



function scrollTo(element) {
    window.scroll({
        behavior: 'smooth',
        left: 0,
        top: element.offsetTop
    });
}




