import './App.css';
import Header from './components/Header';
import User from './components/User';

const friends = [
  {
    id: 1,
    name: "Asya",
  },
  {
    id: 2,
    name: "Sevgi",
  },
  {
    id: 3,
    name: "Ahmet Şevket",
  }
]

function App() {
  return (
    <div>
      <Header />

      <User
        name="Mehmet Akif"
        surname="Yıldız"
        isLogin={true}
        age={39}
        friends={friends}
        adress={{
          title: "Bursa/Mudanya",
          zip: 16250,
        }}
      />

    </div>
  );
}

export default App;
