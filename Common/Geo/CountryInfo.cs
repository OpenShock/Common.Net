﻿using System.Collections.Frozen;

namespace OpenShock.Common.Geo;

public sealed class CountryInfo
{
    public CountryInfo(Alpha2CountryCode countryCode, string name, float latitude, float longitude, string? cfRegion)
    {
        CountryCode = countryCode;
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
        CfRegion = cfRegion;
    }
    
    public Alpha2CountryCode CountryCode { get; init; }
    public string Name { get; init; }
    public float Latitude { get; init; }
    public float Longitude { get; init; }
    public string? CfRegion { get; init; }
    
    public static readonly CountryInfo UnknownCountry = new(Alpha2CountryCode.UnknownCountry, "Unknown", 0f, 0f, null);
    public static readonly CountryInfo[] Countries =
        [
            new("AD", "Andorra", 42.546245f, 1.601554f, "weur"),
            new("AE", "United Arab Emirates", 23.424076f, 53.847818f, "apac"),
            new("AF", "Afghanistan", 33.93911f, 67.709953f, "apac"),
            new("AG", "Antigua and Barbuda", 17.060816f, -61.796428f, "apac"),
            new("AI", "Anguilla", 18.220554f, -63.068615f, "apac"),
            new("AL", "Albania", 41.153332f, 20.168331f, "weur"),
            new("AM", "Armenia", 40.069099f, 45.038189f, "apac"),
            new("AN", "Netherlands Antilles", 12.226079f, -69.060087f, null),
            new("AO", "Angola", -11.202692f, 17.873887f, "apac"),
            new("AQ", "Antarctica", -75.250973f, -0.071389f, "weur"),
            new("AR", "Argentina", -38.416097f, -63.616672f, "apac"),
            new("AS", "American Samoa", -14.270972f, -170.132217f, "apac"),
            new("AT", "Austria", 47.516231f, 14.550072f, "weur"),
            new("AU", "Australia", -25.274398f, 133.775136f, "apac"),
            new("AW", "Aruba", 12.52111f, -69.968338f, "apac"),
            new("AZ", "Azerbaijan", 40.143105f, 47.576927f, "apac"),
            new("BA", "Bosnia and Herzegovina", 43.915886f, 17.679076f, "weur"),
            new("BB", "Barbados", 13.193887f, -59.543198f, "apac"),
            new("BD", "Bangladesh", 23.684994f, 90.356331f, "apac"),
            new("BE", "Belgium", 50.503887f, 4.469936f, "weur"),
            new("BF", "Burkina Faso", 12.238333f, -1.561593f, "apac"),
            new("BG", "Bulgaria", 42.733883f, 25.48583f, "eeur"),
            new("BH", "Bahrain", 25.930414f, 50.637772f, "apac"),
            new("BI", "Burundi", -3.373056f, 29.918886f, "apac"),
            new("BJ", "Benin", 9.30769f, 2.315834f, "apac"),
            new("BM", "Bermuda", 32.321384f, -64.75737f, "enam"),
            new("BN", "Brunei", 4.535277f, 114.727669f, "apac"),
            new("BO", "Bolivia", -16.290154f, -63.588653f, "apac"),
            new("BR", "Brazil", -14.235004f, -51.92528f, "apac"),
            new("BS", "Bahamas", 25.03428f, -77.39628f, "apac"),
            new("BT", "Bhutan", 27.514162f, 90.433601f, "apac"),
            new("BV", "Bouvet Island", -54.423199f, 3.413194f, "apac"),
            new("BW", "Botswana", -22.328474f, 24.684866f, "apac"),
            new("BY", "Belarus", 53.709807f, 27.953389f, "eeur"),
            new("BZ", "Belize", 17.189877f, -88.49765f, "apac"),
            new("CA", "Canada", 56.130366f, -106.346771f, "enam"),
            new("CC", "Cocos [Keeling] Islands", -12.164165f, 96.870956f, "apac"),
            new("CD", "Congo [DRC]", -4.038333f, 21.758664f, "apac"),
            new("CF", "Central African Republic", 6.611111f, 20.939444f, "apac"),
            new("CG", "Congo [Republic]", -0.228021f, 15.827659f, "apac"),
            new("CH", "Switzerland", 46.818188f, 8.227512f, "weur"),
            new("CI", "Côte d'Ivoire", 7.539989f, -5.54708f, "apac"),
            new("CK", "Cook Islands", -21.236736f, -159.777671f, "apac"),
            new("CL", "Chile", -35.675147f, -71.542969f, "apac"),
            new("CM", "Cameroon", 7.369722f, 12.354722f, "apac"),
            new("CN", "China", 35.86166f, 104.195397f, "apac"),
            new("CO", "Colombia", 4.570868f, -74.297333f, "apac"),
            new("CR", "Costa Rica", 9.748917f, -83.753428f, "apac"),
            new("CU", "Cuba", 21.521757f, -77.781167f, "apac"),
            new("CV", "Cape Verde", 16.002082f, -24.013197f, "apac"),
            new("CX", "Christmas Island", -10.447525f, 105.690449f, "apac"),
            new("CY", "Cyprus", 35.126413f, 33.429859f, "apac"),
            new("CZ", "Czech Republic", 49.817492f, 15.472962f, "eeur"),
            new("DE", "Germany", 51.165691f, 10.451526f, "weur"),
            new("DJ", "Djibouti", 11.825138f, 42.590275f, "apac"),
            new("DK", "Denmark", 56.26392f, 9.501785f, "weur"),
            new("DM", "Dominica", 15.414999f, -61.370976f, "apac"),
            new("DO", "Dominican Republic", 18.735693f, -70.162651f, "apac"),
            new("DZ", "Algeria", 28.033886f, 1.659626f, "apac"),
            new("EC", "Ecuador", -1.831239f, -78.183406f, "apac"),
            new("EE", "Estonia", 58.595272f, 25.013607f, "weur"),
            new("EG", "Egypt", 26.820553f, 30.802498f, "apac"),
            new("EH", "Western Sahara", 24.215527f, -12.885834f, "apac"),
            new("ER", "Eritrea", 15.179384f, 39.782334f, "apac"),
            new("ES", "Spain", 40.463667f, -3.74922f, "weur"),
            new("ET", "Ethiopia", 9.145f, 40.489673f, "apac"),
            new("FI", "Finland", 61.92411f, 25.748151f, "weur"),
            new("FJ", "Fiji", -16.578193f, 179.414413f, "apac"),
            new("FK", "Falkland Islands [Islas Malvinas]", -51.796253f, -59.523613f, "apac"),
            new("FM", "Micronesia", 7.425554f, 150.550812f, "apac"),
            new("FO", "Faroe Islands", 61.892635f, -6.911806f, "weur"),
            new("FR", "France", 46.227638f, 2.213749f, "weur"),
            new("GA", "Gabon", -0.803689f, 11.609444f, "apac"),
            new("GB", "United Kingdom", 55.378051f, -3.435973f, "weur"),
            new("GD", "Grenada", 12.262776f, -61.604171f, "apac"),
            new("GE", "Georgia", 42.315407f, 43.356892f, "apac"),
            new("GF", "French Guiana", 3.933889f, -53.125782f, "apac"),
            new("GG", "Guernsey", 49.465691f, -2.585278f, "weur"),
            new("GH", "Ghana", 7.946527f, -1.023194f, "apac"),
            new("GI", "Gibraltar", 36.137741f, -5.345374f, "weur"),
            new("GL", "Greenland", 71.706936f, -42.604303f, "enam"),
            new("GM", "Gambia", 13.443182f, -15.310139f, "apac"),
            new("GN", "Guinea", 9.945587f, -9.696645f, "apac"),
            new("GP", "Guadeloupe", 16.995971f, -62.067641f, "apac"),
            new("GQ", "Equatorial Guinea", 1.650801f, 10.267895f, "apac"),
            new("GR", "Greece", 39.074208f, 21.824312f, "weur"),
            new("GS", "South Georgia and the South Sandwich Islands", -54.429579f, -36.587909f, "apac"),
            new("GT", "Guatemala", 15.783471f, -90.230759f, "apac"),
            new("GU", "Guam", 13.444304f, 144.793731f, "apac"),
            new("GW", "Guinea-Bissau", 11.803749f, -15.180413f, "apac"),
            new("GY", "Guyana", 4.860416f, -58.93018f, "apac"),
            new("GZ", "Gaza Strip", 31.354676f, 34.308825f, null),
            new("HK", "Hong Kong", 22.396428f, 114.109497f, "apac"),
            new("HM", "Heard Island and McDonald Islands", -53.08181f, 73.504158f, "apac"),
            new("HN", "Honduras", 15.199999f, -86.241905f, "apac"),
            new("HR", "Croatia", 45.1f, 15.2f, "weur"),
            new("HT", "Haiti", 18.971187f, -72.285215f, "apac"),
            new("HU", "Hungary", 47.162494f, 19.503304f, "eeur"),
            new("ID", "Indonesia", -0.789275f, 113.921327f, "apac"),
            new("IE", "Ireland", 53.41291f, -8.24389f, "weur"),
            new("IL", "Israel", 31.046051f, 34.851612f, "apac"),
            new("IM", "Isle of Man", 54.236107f, -4.548056f, "weur"),
            new("IN", "India", 20.593684f, 78.96288f, "apac"),
            new("IO", "British Indian Ocean Territory", -6.343194f, 71.876519f, "apac"),
            new("IQ", "Iraq", 33.223191f, 43.679291f, "apac"),
            new("IR", "Iran", 32.427908f, 53.688046f, "apac"),
            new("IS", "Iceland", 64.963051f, -19.020835f, "weur"),
            new("IT", "Italy", 41.87194f, 12.56738f, "weur"),
            new("JE", "Jersey", 49.214439f, -2.13125f, "weur"),
            new("JM", "Jamaica", 18.109581f, -77.297508f, "apac"),
            new("JO", "Jordan", 30.585164f, 36.238414f, "apac"),
            new("JP", "Japan", 36.204824f, 138.252924f, "apac"),
            new("KE", "Kenya", -0.023559f, 37.906193f, "apac"),
            new("KG", "Kyrgyzstan", 41.20438f, 74.766098f, "apac"),
            new("KH", "Cambodia", 12.565679f, 104.990963f, "apac"),
            new("KI", "Kiribati", -3.370417f, -168.734039f, "apac"),
            new("KM", "Comoros", -11.875001f, 43.872219f, "apac"),
            new("KN", "Saint Kitts and Nevis", 17.357822f, -62.782998f, "apac"),
            new("KP", "North Korea", 40.339852f, 127.510093f, "apac"),
            new("KR", "South Korea", 35.907757f, 127.766922f, "apac"),
            new("KW", "Kuwait", 29.31166f, 47.481766f, "apac"),
            new("KY", "Cayman Islands", 19.513469f, -80.566956f, "apac"),
            new("KZ", "Kazakhstan", 48.019573f, 66.923684f, "apac"),
            new("LA", "Laos", 19.85627f, 102.495496f, "apac"),
            new("LB", "Lebanon", 33.854721f, 35.862285f, "apac"),
            new("LC", "Saint Lucia", 13.909444f, -60.978893f, "apac"),
            new("LI", "Liechtenstein", 47.166f, 9.555373f, "weur"),
            new("LK", "Sri Lanka", 7.873054f, 80.771797f, "apac"),
            new("LR", "Liberia", 6.428055f, -9.429499f, "apac"),
            new("LS", "Lesotho", -29.609988f, 28.233608f, "apac"),
            new("LT", "Lithuania", 55.169438f, 23.881275f, "weur"),
            new("LU", "Luxembourg", 49.815273f, 6.129583f, "weur"),
            new("LV", "Latvia", 56.879635f, 24.603189f, "weur"),
            new("LY", "Libya", 26.3351f, 17.228331f, "apac"),
            new("MA", "Morocco", 31.791702f, -7.09262f, "apac"),
            new("MC", "Monaco", 43.750298f, 7.412841f, "weur"),
            new("MD", "Moldova", 47.411631f, 28.369885f, "eeur"),
            new("ME", "Montenegro", 42.708678f, 19.37439f, "weur"),
            new("MG", "Madagascar", -18.766947f, 46.869107f, "apac"),
            new("MH", "Marshall Islands", 7.131474f, 171.184478f, "apac"),
            new("MK", "Macedonia [FYROM]", 41.608635f, 21.745275f, "weur"),
            new("ML", "Mali", 17.570692f, -3.996166f, "apac"),
            new("MM", "Myanmar [Burma]", 21.913965f, 95.956223f, "apac"),
            new("MN", "Mongolia", 46.862496f, 103.846656f, "apac"),
            new("MO", "Macau", 22.198745f, 113.543873f, "apac"),
            new("MP", "Northern Mariana Islands", 17.33083f, 145.38469f, "apac"),
            new("MQ", "Martinique", 14.641528f, -61.024174f, "apac"),
            new("MR", "Mauritania", 21.00789f, -10.940835f, "apac"),
            new("MS", "Montserrat", 16.742498f, -62.187366f, "apac"),
            new("MT", "Malta", 35.937496f, 14.375416f, "weur"),
            new("MU", "Mauritius", -20.348404f, 57.552152f, "apac"),
            new("MV", "Maldives", 3.202778f, 73.22068f, "apac"),
            new("MW", "Malawi", -13.254308f, 34.301525f, "apac"),
            new("MX", "Mexico", 23.634501f, -102.552784f, "apac"),
            new("MY", "Malaysia", 4.210484f, 101.975766f, "apac"),
            new("MZ", "Mozambique", -18.665695f, 35.529562f, "apac"),
            new("NA", "Namibia", -22.95764f, 18.49041f, "apac"),
            new("NC", "New Caledonia", -20.904305f, 165.618042f, "apac"),
            new("NE", "Niger", 17.607789f, 8.081666f, "apac"),
            new("NF", "Norfolk Island", -29.040835f, 167.954712f, "apac"),
            new("NG", "Nigeria", 9.081999f, 8.675277f, "apac"),
            new("NI", "Nicaragua", 12.865416f, -85.207229f, "apac"),
            new("NL", "Netherlands", 52.132633f, 5.291266f, "weur"),
            new("NO", "Norway", 60.472024f, 8.468946f, "weur"),
            new("NP", "Nepal", 28.394857f, 84.124008f, "apac"),
            new("NR", "Nauru", -0.522778f, 166.931503f, "apac"),
            new("NU", "Niue", -19.054445f, -169.867233f, "apac"),
            new("NZ", "New Zealand", -40.900557f, 174.885971f, "apac"),
            new("OM", "Oman", 21.512583f, 55.923255f, "apac"),
            new("PA", "Panama", 8.537981f, -80.782127f, "apac"),
            new("PE", "Peru", -9.189967f, -75.015152f, "apac"),
            new("PF", "French Polynesia", -17.679742f, -149.406843f, "apac"),
            new("PG", "Papua New Guinea", -6.314993f, 143.95555f, "apac"),
            new("PH", "Philippines", 12.879721f, 121.774017f, "apac"),
            new("PK", "Pakistan", 30.375321f, 69.345116f, "apac"),
            new("PL", "Poland", 51.919438f, 19.145136f, "eeur"),
            new("PM", "Saint Pierre and Miquelon", 46.941936f, -56.27111f, "enam"),
            new("PN", "Pitcairn Islands", -24.703615f, -127.439308f, "apac"),
            new("PR", "Puerto Rico", 18.220833f, -66.590149f, "apac"),
            new("PS", "Palestinian Territories", 31.952162f, 35.233154f, "apac"),
            new("PT", "Portugal", 39.399872f, -8.224454f, "weur"),
            new("PW", "Palau", 7.51498f, 134.58252f, "apac"),
            new("PY", "Paraguay", -23.442503f, -58.443832f, "apac"),
            new("QA", "Qatar", 25.354826f, 51.183884f, "apac"),
            new("RE", "Réunion", -21.115141f, 55.536384f, "apac"),
            new("RO", "Romania", 45.943161f, 24.96676f, "eeur"),
            new("RS", "Serbia", 44.016521f, 21.005859f, "weur"),
            new("RU", "Russia", 61.52401f, 105.318756f, "eeur"),
            new("RW", "Rwanda", -1.940278f, 29.873888f, "apac"),
            new("SA", "Saudi Arabia", 23.885942f, 45.079162f, "apac"),
            new("SB", "Solomon Islands", -9.64571f, 160.156194f, "apac"),
            new("SC", "Seychelles", -4.679574f, 55.491977f, "apac"),
            new("SD", "Sudan", 12.862807f, 30.217636f, "apac"),
            new("SE", "Sweden", 60.128161f, 18.643501f, "weur"),
            new("SG", "Singapore", 1.352083f, 103.819836f, "apac"),
            new("SH", "Saint Helena", -24.143474f, -10.030696f, "apac"),
            new("SI", "Slovenia", 46.151241f, 14.995463f, "weur"),
            new("SJ", "Svalbard and Jan Mayen", 77.553604f, 23.670272f, "weur"),
            new("SK", "Slovakia", 48.669026f, 19.699024f, "eeur"),
            new("SL", "Sierra Leone", 8.460555f, -11.779889f, "apac"),
            new("SM", "San Marino", 43.94236f, 12.457777f, "weur"),
            new("SN", "Senegal", 14.497401f, -14.452362f, "apac"),
            new("SO", "Somalia", 5.152149f, 46.199616f, "apac"),
            new("SR", "Suriname", 3.919305f, -56.027783f, "apac"),
            new("ST", "Sao Tomé and Príncipe", 0.18636f, 6.613081f, "apac"),
            new("SV", "El Salvador", 13.794185f, -88.89653f, "apac"),
            new("SY", "Syria", 34.802075f, 38.996815f, "apac"),
            new("SZ", "Swaziland", -26.522503f, 31.465866f, "apac"),
            new("TC", "Turks and Caicos Islands", 21.694025f, -71.797928f, "apac"),
            new("TD", "Chad", 15.454166f, 18.732207f, "apac"),
            new("TF", "French Southern Territories", -49.280366f, 69.348557f, "apac"),
            new("TG", "Togo", 8.619543f, 0.824782f, "apac"),
            new("TH", "Thailand", 15.870032f, 100.992541f, "apac"),
            new("TJ", "Tajikistan", 38.861034f, 71.276093f, "apac"),
            new("TK", "Tokelau", -8.967363f, -171.855881f, "apac"),
            new("TL", "Timor-Leste", -8.874217f, 125.727539f, "apac"),
            new("TM", "Turkmenistan", 38.969719f, 59.556278f, "apac"),
            new("TN", "Tunisia", 33.886917f, 9.537499f, "apac"),
            new("TO", "Tonga", -21.178986f, -175.198242f, "apac"),
            new("TR", "Turkey", 38.963745f, 35.243322f, "apac"),
            new("TT", "Trinidad and Tobago", 10.691803f, -61.222503f, "apac"),
            new("TV", "Tuvalu", -7.109535f, 177.64933f, "apac"),
            new("TW", "Taiwan", 23.69781f, 120.960515f, "apac"),
            new("TZ", "Tanzania", -6.369028f, 34.888822f, "apac"),
            new("UA", "Ukraine", 48.379433f, 31.16558f, "eeur"),
            new("UG", "Uganda", 1.373333f, 32.290275f, "apac"),
            new("UM", "U.S. Minor Outlying Islands", 19.295374f, 166.6280441f, "apac"),
            new("US", "United States", 37.09024f, -95.712891f, "enam"),
            new("UY", "Uruguay", -32.522779f, -55.765835f, "apac"),
            new("UZ", "Uzbekistan", 41.377491f, 64.585262f, "apac"),
            new("VA", "Vatican City", 41.902916f, 12.453389f, "weur"),
            new("VC", "Saint Vincent and the Grenadines", 12.984305f, -61.287228f, "apac"),
            new("VE", "Venezuela", 6.42375f, -66.58973f, "apac"),
            new("VG", "British Virgin Islands", 18.420695f, -64.639968f, "apac"),
            new("VI", "U.S. Virgin Islands", 18.335765f, -64.896335f, "apac"),
            new("VN", "Vietnam", 14.058324f, 108.277199f, "apac"),
            new("VU", "Vanuatu", -15.376706f, 166.959158f, "apac"),
            new("WF", "Wallis and Futuna", -13.768752f, -177.156097f, "apac"),
            new("WS", "Samoa", -13.759029f, -172.104629f, "apac"),
            new("XK", "Kosovo", 42.602636f, 20.902977f, null),
            new("YE", "Yemen", 15.552727f, 48.516388f, "apac"),
            new("YT", "Mayotte", -12.8275f, 45.166244f, "apac"),
            new("ZA", "South Africa", -30.559482f, 22.937506f, "apac"),
            new("ZM", "Zambia", -13.133897f, 27.849332f, "apac"),
            new("ZW", "Zimbabwe", -19.015438f, 29.154857f, "apac"),
        ];

    public static readonly FrozenDictionary<Alpha2CountryCode, CountryInfo> CodeDictionary = Countries.ToFrozenDictionary(x => x.CountryCode, x => x); // Create a frozen dictionary for fast lookups
}
