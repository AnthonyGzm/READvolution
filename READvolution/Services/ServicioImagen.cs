using Firebase.Auth;
using Firebase.Storage;

namespace READvolution.Services
{
    public class ServicioImagen : lServicioImagen
    {
        public async Task<string> SubirImagen(Stream archivo, string nombre)
        {
            string email = "readvolution@gmail.com";
            string clave = "AnthonyGuzman";
            string ruta = "readvolution-bc389.appspot.com";
            string api_key = "AIzaSyBtxoySJt0Ij3Ksdab4CHkOE_9yKEf_Yag";

            var auth = new FirebaseAuthProvider(new FirebaseConfig(api_key));
            var a = await auth.SignInWithEmailAndPasswordAsync(email, clave);

            var cancellation = new CancellationTokenSource();

            var task = new FirebaseStorage(
              ruta,
              new FirebaseStorageOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                  ThrowOnCancel = true
              })

               .Child("Fotos_Perfil")
               .Child(nombre)
               .PutAsync(archivo, cancellation.Token);

            var downloadURL = await task;
            return downloadURL;

        }
    }
}