import Table from "react-bootstrap/Table";
import "bootstrap/dist/css/bootstrap.min.css";
import { Button, Modal } from "react-bootstrap";
import { useState } from "react";
function Users() {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  const [loop, setLoop] = useState([1, 2, 3, 4, 5, 6, 7]);
  return (
    <div style={{ padding: "1rem 8rem" }}>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>ID</th>
            <th>İsim</th>
            <th>Soyisim</th>
            <th>E-posta</th>
            <th>Adres</th>
            <th>#</th>
          </tr>
        </thead>
        <tbody>
          {loop.map(() => (
            <tr>
              <td>1</td>
              <td>Mark</td>
              <td>Otto</td>
              <td>mark@mdo.com</td>
              <td>Şişli/İstanbul</td>
              <td>
                <Button variant="danger" onClick={handleShow}>
                  Kullanıcıyı Sil
                </Button>

                <Modal show={show} onHide={handleClose}>
                  <Modal.Header closeButton>
                    <Modal.Title>Kullanıcıyı sil</Modal.Title>
                  </Modal.Header>
                  <Modal.Body>... kullanıcısını siliyorsunuz!</Modal.Body>
                  <Modal.Footer>
                    <Button variant="secondary" onClick={handleClose}>
                      Close
                    </Button>
                    <Button variant="danger" onClick={handleClose}>
                      Save Changes
                    </Button>
                  </Modal.Footer>
                </Modal>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}

export default Users;
