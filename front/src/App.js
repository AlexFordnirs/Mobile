import {BrowserRouter as Router, Link, Redirect, Route, Switch} from "react-router-dom";
import {useEffect, useState} from "react";

class Phone{
  constructor(name, company, price) {
    this.name = name;
    this.company = company;
    this.price = price;
  }

}


function App() {
  const [phones, setPhones] = useState([]);
  const [company, setCompany] = useState('');

    const MenuStyle = {
        textAlign: 'center',
    }

    const LickStyle = {
        fontSize: '20px',
        margin: '0 20px',
        textDecoration: 'none',
        color: 'black',
        "&:link:hover":{
            background: 'green',
            color: 'gray',
        }

    }


  useEffect(()=>{
        fetch(`http://gfbfda-001-site1.htempurl.com/${company}`)
            .then((response) => {
              return response.json();
            })
            .then((data) => {
              var i = 0;
              let list = [];
              while (i < data.length){
               list.push(new Phone(data[i]['name'], data[i]['company'], data[i]['price']));
                i+=1;
              }
              setPhones(list)
            });
      }, [company]
  );


  return (
    <div className="App">
        <div style={MenuStyle}>
            <button  style={LickStyle} onClick={() => setCompany('')}>Главная </button >
            <button  style={LickStyle} onClick={() => setCompany('Apple')}>Apple </button >
            <button  style={LickStyle} onClick={() => setCompany('Samsung')}>Samsung </button >
            <button  style={LickStyle} onClick={() => setCompany('Google')}>Google </button >
        </div>
        {phones.map((phone) =>
            <p>{phone['name']}-{phone['company']}-{phone['price']}</p>
        )}
    </div>
  );
}

export default App;
