import { Integrater.WebPage } from './app.po';

describe('integrater.web App', () => {
  let page: Integrater.WebPage;

  beforeEach(() => {
    page = new Integrater.WebPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
