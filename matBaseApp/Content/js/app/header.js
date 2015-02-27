$(document).ready(function () {
    $(".dropdown-button").dropdown();
    /*$('.button-collapse').sideNav({
        menuWidth:200, // Default is 240
        edge: 'left', // Choose the horizontal origin
        closeOnClick: true // Closes side-nav on <a> clicks, useful for Angular/Meteor
    });*/
    $('.button-collapse').sideNav({
            menuWidth: 200
    });

});