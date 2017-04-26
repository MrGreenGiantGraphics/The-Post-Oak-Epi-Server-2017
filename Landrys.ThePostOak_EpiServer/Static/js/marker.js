// When the user clicks the marker, an info window opens.

function initMap() {
    var ldryLoc = {lat: 29.547265, lng: -95.020043};
    var cenPoint = {lat: 29.547265, lng: -95.020043};
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 17,
        center: cenPoint
    });

    var contentString = '<div id="content">'+
        '<div id="siteNotice">'+
        '</div>'+
        '<h5>Kemah Boardwalk Inn</h5>'+
        '<div id="bodyContent">'+
        '#8 Kemah Waterfront<br />Kemah, Texas 77565<br />Phone: 281-334-9880<br />Fax: 281-334-9232' +
        '</div>'+
        '</div>';

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    var marker = new google.maps.Marker({
        position: ldryLoc,
        map: map,
        title: 'Kemah Boardwalk Inn'
    });
    marker.addListener('click', function() {
        infowindow.open(map, marker);
    });
}