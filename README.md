# Tmx_Converter_Tool

## Lưu ý :

File txt sẽ dc format theo định dạng :

- Dòng đầu tiên : `idTexture - mapW - mapH - tileW - tileH`

- Những dòng tiếp theo là info các Obj trong map :

- - Đối với các obj tĩnh `( id >= 4500 && < 5000 )` như land, pillar,.. :  `idTypeObj - idObj - x - y - w - h`
 
- - Đối với các obj game bth `( id >= 4000 && < 4500 )` như apple, enermy,.. : `idTypeObj - idObj - x - y - 0 - 0`
