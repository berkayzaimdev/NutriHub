import { Button, Table } from "react-bootstrap";
import { API_BASE_URL } from "../../config";

function Coupons() {
  return (
    <div style={{ padding: "2rem 6rem" }}>
      <div
        style={{
          display: "flex",
          justifyContent: "flex-start", // Butonu sola hizalayacak
          marginBottom: "1rem",
        }}
      >
        <Button
          variant="primary"
          style={{ backgroundColor: "green", border: "none", width: "15rem" }}
        >
          Kupon Ekle
        </Button>
      </div>

      <Table striped bordered hover style={{ marginTop: "2rem" }}>
        <thead>
          <tr>
            <th>#</th>
            <th>Kupon Kodu</th>
            <th>Başlangıç Tarihi</th>
            <th>Bitiş Tarihi</th>
            <th>Toplam Kullanım Sayısı</th>
            <th>Aktif Uygulanma Sayısı</th>
            <th>İşlemler</th>
          </tr>
        </thead>
        <tbody></tbody>
      </Table>
    </div>
  );
}

export default Coupons;
