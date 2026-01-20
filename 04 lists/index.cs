function sendForm() {
            const Formulier = document.querySelector('.dashboard_form');
           
            const name = document.getElementById('name').value;
            const email = document.getElementById('email').value;
            const Favoriete_eten = document.querySelector('Favoriete eten');
            const Favoriete_kleur = document.getElementById('Favoriete kleur');
 
            const bericht = `Naam: ${naam}\n email: ${email}. \n Favoriete eten: ${Favoriete_eten} \n Favoriete_kleur: ${Favoriete_kleur}`;
 
            const mailtoAddress = "40989@ma-web.nl";
            const mailCCAdress = email;
            const mailSubject = `formulier ingevuld door ${naam}`;
            const mailBody = `Beste ${naam},\nBedankt voor het invullen. \n ${bericht}`;
           
            const mailtoLink = `mailto:${mailtoAddress}?cc=${mailCCAdress}&subject=${encodeURIComponent}(mailSubject)&body=${encodeURIComponent(mailBody)}`;
 
            window.location.href = mailtoLink;
        }