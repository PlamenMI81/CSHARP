function solution(arr) {
    let sitesDown = Number(arr[0]);
    let securityKey = arr[1];
    let sitesLoss = 0;
    let countSites = 0;
    for (let i = 2; i < sitesDown + 2; i++) {
        let [siteName, siteVisits, siteCPPV] = arr[i].split(/\s+/g);
        sitesLoss += Number(siteVisits) * Number(siteCPPV);
        if (siteName !== '') {
            countSites++;
            console.log(siteName);
        }
    }
    console.log(`Total Loss: ${(Math.round(1000000000*sitesLoss)/1000000000).toFixed(9).concat('00000000000')}`);
    let secToken = Math.pow(securityKey, countSites);
    console.log(`Security Token: ${secToken}`);
}

solution(
    [
        '3',
        '8',
        'www.google.com 122300 94.23233',
        'www.abv.bg 2333 11',
        'www.kefche.com 12322 23.3222',
        ''
    ]
);

solution([
    '1',
    '1',
    'www.facebook.com 100000 10.45'
]);