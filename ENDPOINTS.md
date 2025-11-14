# ChatbotTCS Admin API - Endpoints

Base URL: `http://localhost:5288` (HTTP) o `https://localhost:7095` (HTTPS)

## 1. USUARIOS (`/api/Usuario`)

### 1.1 Obtener todos los usuarios
```
GET /api/Usuario
```

### 1.2 Obtener usuario por ID
```
GET /api/Usuario/{id}
```

### 1.3 Crear usuario
```
POST /api/Usuario
Content-Type: application/json

{
  "nombre": "Juan Pérez",
  "email": "juan.perez@example.com",
  "dni": "12345678",
  "departamento": "IT",
  "puesto": "Desarrollador",
  "fechaIngreso": "2024-01-15T00:00:00Z",
  "estadoOnboarding": "En Proceso",
  "activo": true
}
```

### 1.4 Actualizar usuario
```
PUT /api/Usuario/{id}
Content-Type: application/json

{
  "nombre": "Juan Pérez Actualizado",
  "email": "juan.perez@example.com",
  "dni": "12345678",
  "departamento": "IT",
  "puesto": "Senior Developer",
  "fechaIngreso": "2024-01-15T00:00:00Z",
  "estadoOnboarding": "Completado",
  "activo": true
}
```

### 1.5 Eliminar usuario
```
DELETE /api/Usuario/{id}
```

### 1.6 Buscar usuario por email
```
GET /api/Usuario/email/{email}
Ejemplo: GET /api/Usuario/email/juan.perez@example.com
```

### 1.7 Buscar usuario por DNI
```
GET /api/Usuario/dni/{dni}
Ejemplo: GET /api/Usuario/dni/12345678
```

### 1.8 Obtener usuarios por estado de onboarding
```
GET /api/Usuario/onboarding/{estado}
Ejemplo: GET /api/Usuario/onboarding/En%20Proceso
```

### 1.9 Obtener usuarios activos
```
GET /api/Usuario/activos
```

### 1.10 Obtener usuarios por departamento
```
GET /api/Usuario/departamento/{departamento}
Ejemplo: GET /api/Usuario/departamento/IT
```

---

## 2. FAQs (`/api/FAQ`)

### 2.1 Obtener todas las FAQs
```
GET /api/FAQ
```

### 2.2 Obtener FAQ por ID
```
GET /api/FAQ/{id}
```

### 2.3 Crear FAQ
```
POST /api/FAQ
Content-Type: application/json

{
  "pregunta": "¿Cómo reseteo mi contraseña?",
  "respuesta": "Puedes resetear tu contraseña desde la página de login haciendo clic en 'Olvidé mi contraseña'",
  "categoria": "Acceso",
  "palabrasClave": ["contraseña", "password", "resetear", "cambiar"],
  "activo": true,
  "prioridad": 5
}
```

### 2.4 Actualizar FAQ
```
PUT /api/FAQ/{id}
Content-Type: application/json

{
  "pregunta": "¿Cómo reseteo mi contraseña?",
  "respuesta": "Respuesta actualizada...",
  "categoria": "Acceso",
  "palabrasClave": ["contraseña", "password"],
  "activo": true,
  "prioridad": 10
}
```

### 2.5 Eliminar FAQ
```
DELETE /api/FAQ/{id}
```

### 2.6 Buscar FAQs
```
GET /api/FAQ/search?query=contraseña
```

---

## 3. DOCUMENTOS (`/api/Documento`)

### 3.1 Obtener todos los documentos
```
GET /api/Documento
```

### 3.2 Obtener documento por ID
```
GET /api/Documento/{id}
```

### 3.3 Crear documento
```
POST /api/Documento
Content-Type: application/json

{
  "titulo": "Manual de Onboarding",
  "descripcion": "Guía completa para nuevos empleados",
  "url": "https://ejemplo.com/manual.pdf",
  "categoria": "Onboarding",
  "tipo": "PDF",
  "tags": ["manual", "onboarding", "guía"],
  "activo": true
}
```

### 3.4 Actualizar documento
```
PUT /api/Documento/{id}
Content-Type: application/json

{
  "titulo": "Manual de Onboarding Actualizado",
  "descripcion": "Guía completa para nuevos empleados - Versión 2",
  "url": "https://ejemplo.com/manual-v2.pdf",
  "categoria": "Onboarding",
  "tipo": "PDF",
  "tags": ["manual", "onboarding"],
  "activo": true
}
```

### 3.5 Eliminar documento
```
DELETE /api/Documento/{id}
```

### 3.6 Obtener documentos por categoría
```
GET /api/Documento/categoria/{categoria}
Ejemplo: GET /api/Documento/categoria/Onboarding
```

### 3.7 Obtener documentos por tipo
```
GET /api/Documento/tipo/{tipo}
Ejemplo: GET /api/Documento/tipo/PDF
```

### 3.8 Buscar documentos por tag
```
GET /api/Documento/tag/{tag}
Ejemplo: GET /api/Documento/tag/manual
```

---

## 4. ACTIVIDADES (`/api/Actividad`)

### 4.1 Obtener todas las actividades
```
GET /api/Actividad
```

### 4.2 Obtener actividad por ID
```
GET /api/Actividad/{id}
```

### 4.3 Crear actividad
```
POST /api/Actividad
Content-Type: application/json

{
  "titulo": "Reunión de bienvenida",
  "descripcion": "Primera reunión con el equipo",
  "tipo": "Reunión",
  "diaOnboarding": 1,
  "duracionEstimada": 60,
  "obligatoria": true,
  "recursos": ["Sala de conferencias", "Presentación PowerPoint"],
  "responsable": "RRHH",
  "orden": 1
}
```

### 4.4 Actualizar actividad
```
PUT /api/Actividad/{id}
Content-Type: application/json

{
  "titulo": "Reunión de bienvenida actualizada",
  "descripcion": "Primera reunión con el equipo - Actualizado",
  "tipo": "Reunión",
  "diaOnboarding": 1,
  "duracionEstimada": 90,
  "obligatoria": true,
  "recursos": ["Sala de conferencias"],
  "responsable": "RRHH",
  "orden": 1
}
```

### 4.5 Eliminar actividad
```
DELETE /api/Actividad/{id}
```

### 4.6 Obtener actividades por día
```
GET /api/Actividad/dia/{dia}
Ejemplo: GET /api/Actividad/dia/1
```

### 4.7 Obtener actividades por tipo
```
GET /api/Actividad/tipo/{tipo}
Ejemplo: GET /api/Actividad/tipo/Reunión
```

### 4.8 Obtener actividades obligatorias
```
GET /api/Actividad/obligatorias
```

---

## 5. CONFIGURACIÓN (`/api/Configuracion`)

### 5.1 Obtener todas las configuraciones
```
GET /api/Configuracion
```

### 5.2 Obtener configuración por ID
```
GET /api/Configuracion/{id}
```

### 5.3 Crear configuración
```
POST /api/Configuracion
Content-Type: application/json

{
  "nombre": "TiempoRespuestaMaximo",
  "valor": "300",
  "tipo": "Chatbot",
  "descripcion": "Tiempo máximo de respuesta en segundos",
  "activo": true
}
```

### 5.4 Actualizar configuración
```
PUT /api/Configuracion/{id}
Content-Type: application/json

{
  "nombre": "TiempoRespuestaMaximo",
  "valor": "600",
  "tipo": "Chatbot",
  "descripcion": "Tiempo máximo de respuesta en segundos - Actualizado",
  "activo": true
}
```

### 5.5 Eliminar configuración
```
DELETE /api/Configuracion/{id}
```

### 5.6 Obtener configuraciones por tipo
```
GET /api/Configuracion/tipo/{tipo}
Ejemplo: GET /api/Configuracion/tipo/Chatbot
```

### 5.7 Obtener configuraciones activas
```
GET /api/Configuracion/activas
```

### 5.8 Buscar configuración por nombre
```
GET /api/Configuracion/nombre/{nombre}
Ejemplo: GET /api/Configuracion/nombre/TiempoRespuestaMaximo
```

---

## 6. CONVERSACIONES (`/api/Conversacion`)

### 6.1 Obtener todas las conversaciones
```
GET /api/Conversacion
```

### 6.2 Obtener conversación por ID
```
GET /api/Conversacion/{id}
```

### 6.3 Crear conversación
```
POST /api/Conversacion
Content-Type: application/json

{
  "usuarioId": "usuario123",
  "mensajes": [
    {
      "remitente": "Usuario",
      "contenido": "Hola, necesito ayuda",
      "timestamp": "2024-01-15T10:00:00Z"
    }
  ],
  "estado": "Activa",
  "categoriaConsulta": "Soporte",
  "resuelto": false
}
```

### 6.4 Actualizar conversación
```
PUT /api/Conversacion/{id}
Content-Type: application/json

{
  "usuarioId": "usuario123",
  "mensajes": [],
  "estado": "Cerrada",
  "categoriaConsulta": "Soporte",
  "resuelto": true
}
```

### 6.5 Eliminar conversación
```
DELETE /api/Conversacion/{id}
```

### 6.6 Obtener conversaciones por usuario
```
GET /api/Conversacion/usuario/{usuarioId}
Ejemplo: GET /api/Conversacion/usuario/usuario123
```

### 6.7 Obtener conversaciones activas
```
GET /api/Conversacion/activas
```

### 6.8 Obtener conversaciones resueltas
```
GET /api/Conversacion/resueltas
```

### 6.9 Agregar mensaje a conversación
```
POST /api/Conversacion/{id}/mensajes
Content-Type: application/json

{
  "remitente": "Chatbot",
  "contenido": "¿En qué puedo ayudarte?",
  "timestamp": "2024-01-15T10:01:00Z"
}
```

---

## 7. MENSAJES AUTOMÁTICOS (`/api/MensajeAutomatico`)

### 7.1 Obtener todos los mensajes automáticos
```
GET /api/MensajeAutomatico
```

### 7.2 Obtener mensaje automático por ID
```
GET /api/MensajeAutomatico/{id}
```

### 7.3 Crear mensaje automático
```
POST /api/MensajeAutomatico
Content-Type: application/json

{
  "titulo": "Mensaje de Bienvenida",
  "contenido": "Bienvenido a TCS! Estamos aquí para ayudarte.",
  "tipo": "Bienvenida",
  "trigger": "UsuarioNuevo",
  "activo": true,
  "prioridad": 1
}
```

### 7.4 Actualizar mensaje automático
```
PUT /api/MensajeAutomatico/{id}
Content-Type: application/json

{
  "titulo": "Mensaje de Bienvenida Actualizado",
  "contenido": "Bienvenido a TCS! Estamos aquí para ayudarte en todo momento.",
  "tipo": "Bienvenida",
  "trigger": "UsuarioNuevo",
  "activo": true,
  "prioridad": 2
}
```

### 7.5 Eliminar mensaje automático
```
DELETE /api/MensajeAutomatico/{id}
```

### 7.6 Obtener mensajes automáticos por tipo
```
GET /api/MensajeAutomatico/tipo/{tipo}
Ejemplo: GET /api/MensajeAutomatico/tipo/Bienvenida
```

### 7.7 Obtener mensajes automáticos activos
```
GET /api/MensajeAutomatico/activos
```

---

## Códigos de Respuesta HTTP

- `200 OK` - Operación exitosa
- `201 Created` - Recurso creado exitosamente
- `204 No Content` - Operación exitosa sin contenido de retorno
- `400 Bad Request` - Datos de entrada inválidos
- `404 Not Found` - Recurso no encontrado
- `500 Internal Server Error` - Error del servidor

---

## Notas para Pruebas

1. **Iniciar la API**: Ejecuta `dotnet run` en la carpeta del proyecto
2. **Herramientas de prueba recomendadas**:
   - Postman
   - Thunder Client (VS Code)
   - cURL
   - Swagger UI (si está habilitado)

3. **MongoDB**: Asegúrate de que tu conexión a MongoDB esté configurada en `appsettings.json`

4. **Headers requeridos**:
   - Para POST/PUT: `Content-Type: application/json`

5. **Formato de fechas**: Usa formato ISO 8601: `2024-01-15T10:00:00Z`
