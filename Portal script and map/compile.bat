vbsp -entity_limit 1750 -game C:\Progra~2\Portal~1\portal2\ "C:\Program Files (x86)\Portal 2\sdk_content\maps\jump_jump.vmf"

vvis -game C:\Progra~2\Portal~1\portal2\ C:\Progra~2\Portal~1\sdk_content\maps\jump_jump.bsp

vrad -final -staticproppolys -staticproplighting -textureshadows -hdr -game C:\Progra~2\Portal~1\portal2\ C:\Progra~2\Portal~1\sdk_content\maps\jump_jump.bsp

copy C:\Progra~2\Portal~1\sdk_content\maps\jump_jump.bsp "C:\Program Files (x86)\Portal 2\portal2\maps\test_map.bsp"
