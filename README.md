# ChallengeKoibanx

El proyecto se realizo esperando seguir las instrucciones requeridas en el documento.

## Back-End
Se utilizo .NetCore para el backend, usando Clean Architecture en su estructura creando la entidad Commerce, los metodos Business y Business por Filter, presentado con documentacion Swagger. Los pasos para correr el backend son:

* En el archivo Startup.cs modificar el puerto que despliegue el frontend en los CORS para permitir el origen. Line 41.
* En visualCode con el comando: dotnet watch run, o ejecutarlo desde visual studio.

## Front-End
Para el frontend se creo una estructura limpia de flujo se cuenta con un Store en MobX y Hooks para los componentes reactivos, el componente de Busqueda hace uso del servicio Business Filter, para traer la informacion ya sea filtrada por Id, CUIT, o Comercio. Pasos para ejecutar el FrontEnd:

* En el archivo agent.ts modificar el puerto que despliega el backend. Line 4
* Comando: npm install
* Comando: npm start
