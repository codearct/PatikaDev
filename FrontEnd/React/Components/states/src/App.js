import { useState } from "react";


function App() {

  const [name, setName] = useState("Rıfkı");
  const [age, setAge] = useState(39)
  const [friends, setFriends] = useState(["Ahmet", "Ali", "Fatma"])
  const [adress, setAdress] = useState({ title: "Afyon", zip: "03245" })

  return (
    <div>
      <h1>Merhaba {name}!</h1>
      <h2>{age}</h2>

      <button onClick={() => setName("Mehmet")}>Change Name</button>
      <button onClick={() => setAge(40)}>Change Age</button>

      <br /><br />
      <hr />


      <h2>Friends</h2>

      {friends.map((friend, index) => (
        <div key={index}>{friend}</div>
      ))}
      <br />
      <button onClick={() => setFriends([...friends, "Zeynep"])}>Add New Friend</button>

      <br /><br />
      <hr />

      <h2>Adress</h2>
      <div>{adress.title} {adress.zip}</div>

      <br />
      <button onClick={() => setAdress({ ...adress, title: "Bursa", zip: "16250" })}>Change Adress</button>

    </div>
  );
}

export default App;
