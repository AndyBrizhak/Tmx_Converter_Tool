# Tmx_Converter_Tool

## Lưu ý :

File tmx sẽ được covert sang 2 file :

- Obj.txt :

- - Đối với các obj tĩnh `( id >= 4500 && < 5000 )` như land, pillar,.. :  `idTypeObj - idObj - left - top - right - bottom`
 
- - Đối với các obj game bth `( id >= 4000 && < 4500 )` như apple, enermy,.. : `idTypeObj - idObj - x - y - 0 - 0`

- Tile.txt

- - Lưu từng Tile với định dạnh `idUnit - left - top - right - bottom`  
