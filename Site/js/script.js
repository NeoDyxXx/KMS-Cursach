var modal = document.getElementsByClassName('modal');

for (let i = 0; i < modal.length; i++)
{
    // Get the image and insert it inside the modal - use its "alt" text as a caption
    var img = modal[i].parentElement.getElementsByClassName('myImg');

    for (let j = 0; j < img.length; j++)
    {
        img[j].onclick = function(){
            modal[i].style.display = "block";
            modal[i].getElementsByClassName("modal_img")[0].src = this.src;
            modal[i].getElementsByClassName("modal_caption")[0].innerHTML = this.alt;
        }
    }

    // Get the <span> element that closes the modal
    var span = modal[i].getElementsByClassName("close")[0];

    // When the user clicks on <span> (x), close the modal
    span.onclick = function() { 
        modal[i].style.display = "none";
    }
}

document.getElementsByClassName("header_burger")[0].onclick = function() {
    document.getElementsByClassName("sliiide_menu")[0].style.left = 0;
}

document.getElementsByClassName("sliiide_menu_exit")[0].onclick = function() {
    document.getElementsByClassName("sliiide_menu")[0].style.left = -300;
}