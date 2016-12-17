# BMPClient

A simple BMP ([BGP Monitoring Protocol](https://tools.ietf.org/html/rfc7854)) client. BMP is currently supported on Cisco devices running IOS XE 3.12.0/15.4.2 or above, Cisco devices running IOS XR 5.2.2  and on Juniper devinces running JunOS 13.3 or above.

BMP, provides a convenient interface for the collection of route views. The introduction of BMP allows network operators to grant access to a Adj-RIB stream of a peer along with periodic dumps of certain statistics. It is not noecessary to peer with or grant logon accsess to the network device generating the BMP information. The messages are received on a BMP monitoring station. This code is a first attempt at such a monitoring station.

Currently BMPClient shows all received BMP messages on the console formatted in JSON. 

# Example Output
```
{"Header":{"Version":3,"Length":123,"Type":0},"PeerHeader":{"PeerType":0,"IsPostPolicy":false,"PeerDistinguisher":0,"PeerAddress":"2001:470:d6:70::1","PeerAS":6939,"PeerBGPId":"64.71.128.26","Timestamp":"2016-12-16T13:28:31Z","Flags":128},"Body":{"BGPUpdate":{"Header":{"Length":75,"Type":2},"Body":{"WithdrawnRoutesLength":0,"WithdrawnRoutes":null,"TotalPathAttributeLength":52,"PathAttributes":[{"Origin":0,"Flags":64,"Type":1,"Length":1},{"ASPaths":[{"SegmentType":2,"Length":3,"ASNs":[6939,14840,264555]}],"Flags":64,"Type":2,"Length":14},{"NextHop":"2001:470:d6:70::1","LinkLocalNextHop":null,"AFI":2,"SAFI":1,"Value":["2804:2174:cb::/48"],"Flags":128,"Type":14,"Length":28}]}}}}
```
