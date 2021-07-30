import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import './Style.css';

function App() {
  const [data, setData] = useState([]);
  return (
     <>
      <div>
        <label>NIK : </label>
        <input type="number" name="NIK"/>
        <br/>
        <label>Nama : </label>
        <input type="text" name="nama"/>
        <br/>
        <label>Tempat lahir : </label>
        <input type="text" name="TempatLahir"/>
        <br/>
        <label>Tgl Lahir : </label>
        <input type="datetime-local" name="TglLahir"/>
        <br/>
        <label>Jenis Kelamin : </label>
        <input type="text" name="Jenis"/>
        <br/>
        <label>Alamat : </label>
        <input type="text" name="alamat"/>
        <br/>
        <label>RT : </label>
        <input type="number" name="RT"/>
        <br/>
        <label>RW : </label>
        <input type="number" name="RW"/>
        <br/>
        <label>Kelurahan : </label>
        <input type="text" name="Kelurahan"/>
        <br/>
        <label>Kecamatan : </label>
        <input type="text" name="Kecamatan"/>
        <br/>
        <label>Agama : </label>
        <input type="text" name="Agama"/>
        <br/>
        <label>Status Perkawinan : </label>
        <input type="text" name="Status"/>
        <br/>
        <label>Pekerjaan : </label>
        <input type="text" name="Pekerjaan"/>
        <br/>
        <label>Kewarganegaraan : </label>
        <input type="text" name="Kewarganegaraan"/>
        <br/>
        <label>Berlaku Hingga : </label>
        <input type="text" name="Berlaku"/>
        <br/>
        <label>URL foto : </label>
        <input type="text" name="foto"/>
        <br/>
        <button onClick={() => {
          let nik = document.getElementsByName("NIK")[0].value;
          let nama = document.getElementsByName("nama")[0].value;
          let tempat = document.getElementsByName("TempatLahir")[0].value;
          let tanggal = document.getElementsByName("TglLahir")[0].value;
          let gender = document.getElementsByName("Jenis")[0].value;
          let alamat = document.getElementsByName("alamat")[0].value;
          let rt = document.getElementsByName("RT")[0].value;
          let rw = document.getElementsByName("RW")[0].value;
          let kelurahan = document.getElementsByName("Kelurahan")[0].value;
          let kecamatan = document.getElementsByName("Kecamatan")[0].value;
          let agama = document.getElementsByName("Agama")[0].value;
          let status = document.getElementsByName("Status")[0].value;
          let pekerjaan = document.getElementsByName("Pekerjaan")[0].value;
          let kewarganegaraan = document.getElementsByName("Kewarganegaraan")[0].value;
          let berlaku = document.getElementsByName("Berlaku")[0].value;
          let foto = document.getElementsByName("foto")[0].value;
          let databaru = Object.assign([], data);
          databaru.push({
            nik : nik,
            nama : nama,
            tempat : tempat,
            tanggal : tanggal,
            gender : gender,
            alamat : alamat,
            rt : rt,
            rw : rw,
            kelurahan : kelurahan,
            kecamatan : kecamatan,
            agama : agama,
            status : status,
            pekerjaan : pekerjaan,
            kewarganegaraan : kewarganegaraan,
            berlaku : berlaku,
            foto : foto
          })

          setData(databaru);
        }}>Terapkan</button>
      </div>
        {data.map((KTP) => {
          return(
            <Dataktp nik={KTP.nik}
                     nama={KTP.nama}
                     tempat={KTP.tempat}
                     tanggal={KTP.tanggal}
                     gender={KTP.gender}
                     alamat={KTP.alamat}
                     rt={KTP.rt}
                     rw={KTP.rw}
                     kelurahan={KTP.kelurahan}
                     kecamatan={KTP.kecamatan}
                     agama={KTP.agama}
                     status={KTP.status}
                     pekerjaan={KTP.pekerjaan}
                     kewarganegaraan={KTP.kewarganegaraan}
                     berlaku={KTP.berlaku}
                     foto={KTP.foto} />
            
          )


        }
        )}    
    </> 
  );
}

function Dataktp(props){
  return (
    <div className="data">
      <div className="provinsi">
      <h3>PROVINSI KEPULAUAN RIAU</h3>
      <h3 id="kota">KOTA BATAM</h3>
      </div>
      <div id="foto" className="Foto">
      <Foto url={props.foto}/>
      </div>
      <h3>NIK : {props.nik}</h3>
      <p>Nama : {props.nama}</p>
      <p>Tempat/Tgl Lahir : {props.tempat},{props.tanggal}</p>
      <p>Jenis Kelamin : {props.gender}</p>
      <p>Alamat : {props.alamat}</p>
      <p>RT/RW : {props.rt}/{props.rw}</p>
      <p>Kelurahan : {props.kelurahan}</p>
      <p>Kecamatan : {props.kecamatan}</p>
      <p>Agama : {props.agama}</p>
      <p>Status Perkawinan : {props.status}</p>
      <p>Pekerjaan : {props.pekerjaan}</p>
      <p>Kewarganegaraan : {props.kewarganegaraan}</p>
      <p>Berlaku Hingga : {props.berlaku}</p>
      
    </div>
  )

}

function Foto(props){
  return (
    <img src={props.url}/>
  )
}



export default App;
